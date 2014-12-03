
#r @"packages/FAKE.3.4.3/tools/FakeLib.dll"

open System
open System.IO
open Fake

let buildDir = "./builds"
let assignmentDir = sprintf "%s/assignments" buildDir 

let partDir x = sprintf "%s/part%d" assignmentDir x

Target "Clean" (fun _ ->
    CleanDirs [buildDir]
)

let buildTargetBuilder x = 
  let part = sprintf "Part%d/*.fsproj" x
  Target (sprintf "buildPart%d" x) (fun _ ->
    !! (part)
      |> MSBuildRelease (partDir x) "Build"
            |> Log "AppBuild-Output: "
  )

let validateTargetBuilder x =
  Target (sprintf "validatePart%d" x) (fun _ ->
      !! ((partDir x)+ "/*.Tests.dll")
        |> NUnit (fun p ->
            {p with
               DisableShadowCopy = true;
               OutputFile = assignmentDir + "TestResults.xml" })
  )

let depencyTargetBuilder x= 
  (sprintf "buildPart%d") x 
    ==> (sprintf "validatePart%d") x

let parts = [1..4]

parts |> List.iter buildTargetBuilder
parts |> List.iter validateTargetBuilder
parts |> List.iter (fun x -> depencyTargetBuilder x |> ignore)


Target "Graduate" (fun _ ->
  trace "Congrats!!!. You passed the class!!"
)

"validatePart1"          
  ==> "validatePart2"
  ==> "Graduate" 


RunTargetOrDefault "Graduate"