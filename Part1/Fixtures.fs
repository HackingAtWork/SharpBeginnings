module NUnit.TickSpec

open NUnit.Framework
open System.IO
open System.Reflection
open TickSpec
open AssignmentHelper

let assembly = Assembly.GetExecutingAssembly() 
let definitions = new StepDefinitions(assembly)

type FibonacciFeature () = inherit FeatureFixture("FibonacciFeature.txt", definitions)
//type SortingFeature () = inherit FeatureFixture("SortingFeature.txt", definitions)
//type CollectionFeature () = inherit FeatureFixture("SimpleCollectionFeature.txt", definitions)
//type AnagramFeature () = inherit FeatureFixture("AnagramFeature.txt", definitions)
//type ReverseFeature () = inherit FeatureFixture("ReverseFeature.txt", definitions)
