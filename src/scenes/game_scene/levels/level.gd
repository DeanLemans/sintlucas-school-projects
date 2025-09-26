extends Node

#signal level_won
#signal level_lost

var level_state : LevelState

func _ready() -> void:
	level_state = GameState.get_level_state(scene_file_path)
