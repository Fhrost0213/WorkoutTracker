using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WorkoutTracker.WebAPI.Controllers;
using WorkoutTracker.Core.Models;
using WorkoutTracker.Core.Services;

namespace WorkoutTracker.Tests.Controllers
{
    [TestClass]
    public class ExerciseControllerTests
    {
        private ExerciseController _sut;

        [TestMethod]
        public void Get_ShouldReturnExercises()
        {
            // Arrange
            var exercises = new List<Exercise> { new Exercise { Description = "Test", Id = 1, Name = "Test" } };

            var exerciseServiceMock = new Mock<IExerciseService>();
            exerciseServiceMock.Setup(x => x.GetExercises()).Returns(exercises);
            _sut = new ExerciseController(exerciseServiceMock.Object);

            // Act
            var result = _sut.Get();

            // Assert
            Assert.AreEqual(exercises, result);
        }

        [TestMethod]
        public void Get_ShouldReturnSpecificExercises()
        {
            // Arrange
            var exercise = new Exercise { Description = "Test", Id = 1, Name = "Test" } ;

            var exerciseServiceMock = new Mock<IExerciseService>();
            exerciseServiceMock.Setup(x => x.GetExercise(1)).Returns(exercise);
            _sut = new ExerciseController(exerciseServiceMock.Object);

            // Act
            var result = _sut.Get(1);

            // Assert
            Assert.AreEqual(exercise, result);
        }
    }
}
