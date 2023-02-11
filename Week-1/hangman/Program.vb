Imports System

Module Program
    Sub Main(args As String())
    ' Opening statement, let's the user know what game they will be playing 
        Console.WriteLine("Hello! Let's play hangman")
    ' this variable keeps track of how many mistakes the player has made
        dim mistakes as integer = 6
    ' this is hardcoded but can be changed for new games, this variable contatins the word
    ' to be guessed
        dim mysteryWord as string = "mystery"
    ' represents all the letters the player has guessed before
        dim guesses as string = ""
    ' this copy of the mystery word will be manipulated to only retain letters that 
    ' have yet to be guessed by the player / end user 
        dim mysteryWordCopy as string = mysteryWord
        Console.WriteLine("The mystery word has {0} letters", mysteryWord.Length)
        ' mistakes > 0 - check that the player hasn't run out of wrong guesses
        ' mysteryWordCopy.Length > 0 - check that there are still letters to be guessed
        ' we use the boolean operator and because both conditions must be true for the 
        ' player to keep guessing (ie we don't want a player to guess when they've run out
        ' out of chances or they already won)
        while mistakes > 0 and mysteryWordCopy.Length > 0
            Console.WriteLine("Enter your guess please: ")
            'this variable will contain the current guess
            dim guess as string = Console.ReadLine()
            'input validation to make sure only one letter is being inputted
            if(guess.Length > 1) then
            Console.WriteLine("Please input only one letter at a time")
            Continue While
            end if
            ' check if the letter that has been guessed is in the mysteryWord
            'or mysteryWordCopy (we use copy since its a shorter length so shorter search)
            ' contains method returns a boolean of whether or not mysteryWordCopy has an instance
            ' of guess
            if(mysteryWordCopy.contains(guess)) Then
            Console.WriteLine("mystery word has that letter")
            ' replace is another method that replaces all instances of guess with "" in the 
            ' mysteryword copy
            ' first param in replace is the substring to be replaced
            ' second param in the replace is the substring you're including in the string instead
            ' in this instance, we are replacing instances of the correctly guessed letter 
            ' with nothing, essentially deleting letters from the mysteryWordCopy
            mysteryWordCopy = mysteryWordCopy.Replace(guess, "")
            Else
                Console.WriteLine("mystery word does not contain that letter")
                mistakes = mistakes - 1
            end if
            guesses += guess
            ' Print out the current state of the mysteryWord
            ' if we guessed the letter, print it out, otherwise, print a # sign
            For Each letter As char In mysteryWord
                if(guesses.Contains(letter)) Then 
                Console.Write(letter)
                else 
                Console.Write("#")
                end if
            Next    
            Console.WriteLine()        
        end while
        ' if the mysteryWordCopy has letters to be guesed, then the player ran out of
        ' chances and lost. Else, the player won
        if(mysteryWordCopy.Length > 0) then 
        Console.WriteLine("You lost! The word was {0}", mysteryWord)
        else Console.WriteLine("You guessed it! Congrats!")
        end if
    End Sub
End Module