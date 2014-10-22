module StringManipulationStepDefinition

open TickSpec
open NUnit.Framework
open FsUnit

let mutable resultSet:int seq = {0..1}
let mutable fibonnaciNumber:int = -1
let upperBound = 10000

let rec fibonnaci x = 
    match x with
    | 1 | 2 -> 1
    | x -> fibonnaci (x-1) + fibonnaci (x-2) 
    
let fibonnaciSequence x=
  // need a range of numbers
  // need to convert that list of numbers in to fibonacci
  // need to select first x fibonacci numbers
     seq {1..upperBound}
     |> Seq.map fibonnaci
     |> Seq.take x
    

let [<Given>] ``a fibonacci sequence calculator`` ()= 
    ()
      
let [<When>] ``I ask for the first (.*) numbers in the sequence`` (n:int) =  
    resultSet <- fibonnaciSequence n
   
let [<When>] ``I ask for the Fibonacci number of (.*)`` (n:int) =  
    fibonnaciNumber <- fibonnaci n

let [<Then>] ``the fib result should be (.*)`` (expected:int) =  
    Assert.AreEqual(expected, fibonnaciNumber)

let [<Then>] ``the fib set should contain (.*)`` (expected:int) =  
    let doesExist=resultSet|> Seq.exists (fun x-> x= expected)
    Assert.IsTrue(doesExist, "Could not find it")

let [<Then>] ``the fib result set length should be (.*)`` (len:int) =  
    let cnt = Seq.length resultSet
    Assert.AreEqual(len, cnt)
