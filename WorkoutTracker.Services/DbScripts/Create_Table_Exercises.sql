CREATE TABLE Exercises (
	ExerciseId INT NOT NULL IDENTITY PRIMARY KEY,
	ExerciseName VARCHAR(255) NOT NULL,
	ExerciseDescription VARCHAR(255),
	AddDate DATE,
	AddName VARCHAR(255)
)