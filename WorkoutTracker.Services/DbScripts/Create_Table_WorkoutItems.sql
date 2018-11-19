CREATE TABLE WorkoutItems (
	WorkoutItemId INT NOT NULL IDENTITY PRIMARY KEY,
	ExerciseId INT,
	Reps INT,
	Weight DECIMAL,
	WorkoutItemDate DATE,
	AddDate DATE,
	AddName VARCHAR(255),
	FOREIGN KEY(ExerciseId) REFERENCES Exercises(ExerciseId)
)