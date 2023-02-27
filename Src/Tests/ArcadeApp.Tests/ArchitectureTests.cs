using System;
using ArcadeApp.Domain.Utility;
using NetArchTest.Rules;

namespace ArcadeApp.Tests
{
	public class ArchitectureTests
	{
		private const string DomaninNamespace = "Domain";
		private const string ApplicationNamespace = "Application";
		private const string PersistenceNamespace = "Persistence";
		private const string ApiNamespace = "API";


        [Fact]
		public void Domain_Should_Not_HaveDependencyOnOtherProjects()
		{
			var assembly = typeof(Domain.Utility.AssemblyReference).Assembly;

			var otherProjects = new[]
			{
				ApplicationNamespace,
				PersistenceNamespace,
                ApiNamespace

            };

			var testResut =
				Types
				.InAssembly(assembly)
				.ShouldNot()
				.HaveDependencyOnAll(otherProjects)
				.GetResult();

			Assert.True(testResut.IsSuccessful);
		}

        [Fact]
        public void Application_Should_Not_HaveDependencyOnOtherProjects()
        {
            var assembly = typeof(Application.Utility.AssemblyReference).Assembly;

            var otherProjects = new[]
            {
                PersistenceNamespace,
                ApiNamespace
            };

            var testResut =
                Types
                .InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOnAll(otherProjects)
                .GetResult();

            Assert.True(testResut.IsSuccessful);
        }

        [Fact]
        public void Persistence_Should_Not_HaveDependencyOnOtherProjects()
        {
            var assembly = typeof(Persistence.Utility.AssemblyReference).Assembly;

            var otherProjects = new[]
            {
               
                ApiNamespace
            };

            var testResut =
                Types
                .InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOnAll(otherProjects)
                .GetResult();

            Assert.True(testResut.IsSuccessful);
        }
    }
}

