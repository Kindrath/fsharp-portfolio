module fsharpPortfolioTests.Program

open Expecto
open fsharpPortfolioTests.Week1Tests

[<EntryPoint>]
let main argv =
    runTestsWithCLIArgs [] argv tests
