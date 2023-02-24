Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Enter a mystery Word: ")
        dim mysteryWord as string = Console.readline()
        Console.Write("Enter amount of chances: ")
        dim strChances as string = Console.readline()
        dim numChances as integer = Integer.Parse(strChances)

        wordFunc(mysteryWord, numChances)
    End Sub

    sub wordFunc(mysteryWord as string, numChances as integer)
        
        dim guesses as string = ""
        dim mysteryWordcopy = mysteryWord

        For index As integer = 0 to numChances
            
            Console.Write("Enter a letter: ")
            dim guess as string = Console.readline()

            if(mysteryWord.contains(guess)) then
                guesses = guesses + guess
                mysteryWordcopy.replace(guess, "")  
            else 
                Console.Writeline("Try Again!")
            end if
            
            For Each letter As char In mysteryWord
                if(guesses.contains(letter)) then
                    Console.Write(letter)
                else
                    console.Write("#")
                end if
            Next
            console.Writeline()
        Next index

    end sub
End Module
