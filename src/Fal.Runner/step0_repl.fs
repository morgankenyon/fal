namespace Fal

module step0 =
    let read (str: string) = str

    let eval (ast: string) = ast

    let print (exp: string) = exp

    let rep str =
        str
        |> read
        |> eval
        |> print

    let launch () =
        printfn "Launching step0 interpreter: just outputting what you provided.\n"
        while true do
            printf "fal> "
            let line = System.Console.ReadLine()

            let output = rep line

            printfn "%s" output
