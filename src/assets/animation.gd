extends CharacterBody2D

@export var low_body : AnimatedSprite2D
@export var high_body : AnimatedSprite2D

func _process(_delta: float) -> void:
	if velocity.length() > 0:
		low_body.play("walk")
	else:
		low_body.stop()

	if Input.is_action_pressed("shoot"):
		high_body.play("shoot")
	else:
		high_body.stop()
