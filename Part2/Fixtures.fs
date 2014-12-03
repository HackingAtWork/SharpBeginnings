module NUnit.TickSpec

open System.Reflection
open AssignmentHelper
open TickSpec

let assembly = Assembly.GetExecutingAssembly() 
let definitions = new StepDefinitions(assembly)
type Feature () = inherit FeatureFixture("StockFeature.txt", definitions)