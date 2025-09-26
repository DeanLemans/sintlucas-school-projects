#script for all the player stuff, this is located under a Node2D and under the Node2D is a CharacterBody2D
extends Node2D

var velocity: Vector2 = Vector2.ZERO

@export var bullet_path: PackedScene = null
#@export var BulletOrigin: Node2D
@export var character_body: CharacterBody2D
#@export var Camara: Camera2D
@export var shoot_timer: Timer

@export var speed: float = 300.0
@export var accel: float = 300.0

var is_ready: bool = true

func _ready() -> void:
	if not character_body:
		character_body = $CharacterBody2D
		
func _physics_process(_delta: float) -> void:
	var mouse_position: Vector2 = get_global_mouse_position()
	var direction: Vector2 = mouse_position - character_body.global_position
	var angle: float = direction.angle()

	if character_body:
		if Input.is_action_pressed("right"):
			velocity.x += 1
			print("right")
		if Input.is_action_pressed("left"):
			velocity.x -= 1
			print("left")
		if Input.is_action_pressed("down"):
			velocity.y += 1
			print("down")
		if Input.is_action_pressed("up"):
			velocity.y -= 1
			print("up")
		
		velocity = velocity.normalized() * speed
		character_body.velocity = velocity
		var _move_success: bool = character_body.move_and_slide()
		character_body.rotation = angle
		
		if Input.is_action_just_pressed("shoot") and is_ready:
			is_ready = false
			shoot_timer.start()
			shoot(direction)

func shoot(direction: Vector2) -> void:
	var bullet: CharacterBody2D = bullet_path.instantiate()
	bullet.direction = direction.normalized()
	bullet.position = %BulletOrigin.global_position
	bullet.global_rotation = character_body.global_rotation
	get_parent().add_child(bullet)

func _on_shoot_timer_timeout() -> void:
	is_ready = true
