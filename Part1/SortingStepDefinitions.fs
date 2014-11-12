module SortingStepDefinitions

open TickSpec
open NUnit.Framework
open FsUnit
open System

let mutable sortedSet:int list=[]
let randomCollection = 
    let rnd = System.Random()
    List.init 15 (fun _ -> rnd.Next ())

let listSorter (tobeSorted : int list)=
   //todo: implement an algorithm that takes the list 'tobeSorted' and returns a sorted list
   //hints : see how you can be implement sorting algorithms found here http://en.wikipedia.org/wiki/Sorting_algorithm
    [0] 

let [<Given>] ``a random collection`` () = 
    ()

let [<When>] ``I sort that collection`` () =  
    sortedSet <- (listSorter randomCollection)

let [<Then>] ``the sorting result should be sorted`` () =  
    let expectedSort = List.sort randomCollection
    let res = (set expectedSort = set sortedSet)

    printfn "Expecting:"
    expectedSort |> List.iter (fun x-> printf "%d," x)
    printfn "\n Found:"
    sortedSet |> List.iter (fun x-> printf "%d" x)
    printfn ""
    Assert.IsTrue(res, "Was not sorted well")