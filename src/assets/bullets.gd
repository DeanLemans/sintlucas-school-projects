extends CharacterBody2D

var direction: Vector2 = Vector2.ZERO
var speed: float = 500.0

func _ready() -> void:
	velocity = direction * speed

func _physics_process(delta: float) -> void:
	var collision : KinematicCollision2D = move_and_collide(velocity * delta)
	if collision:
		velocity = velocity.bounce(collision.get_normal())
		velocity *= 0.95  # Adjust factor as needed

func _on_VisibilityNotifier2D_screen_exited() -> void:
	queue_free() # Deletes bullet when it exits the screen
