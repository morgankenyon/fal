namespace Fal

module Program =

    open System

    [<EntryPoint>]
    let main argv =
        printfn("Welcome to Fal");
        printfn("Please select which step of the Lisp interpreter you'd like to run:");
        printfn("    0 - step0_repl - just prints back what you ask it")

        printf "fal> "
        
        
        let line = Console.ReadLine()

        match line with
        | "0" ->
            step0.launch()
        | _ -> printfn "Option '%s' is not available at this time" line
        0