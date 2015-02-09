module AssignmentHelper

open NUnit.Framework
open System.IO
open System.Reflection
open TickSpec

/// Inherit from FeatureFixture to define a feature fixture
[<AbstractClass>]
[<TestFixture>]
type FeatureFixture (source:string, definitions:StepDefinitions) =
    [<Test>]
    [<TestCaseSource("Scenarios")>]
    member this.TestScenario (scenario:Scenario) =
        if scenario.Tags |> Seq.exists ((=) "ignore") then
            raise (new IgnoreException("Ignored: " + scenario.Name))
        scenario.Action.Invoke()
    member this.Scenarios =
        let s = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(),source))
        definitions.GenerateScenarios(source,s)