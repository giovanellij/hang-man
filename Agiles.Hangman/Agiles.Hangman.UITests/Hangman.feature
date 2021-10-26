Feature: Hangman
	As Agiles.Hangman user
	I want to input individual characters or entire words
	So I can got the result either I guessed the word or not.

@scenary#1
#Scenario: An entire word input and win
#	Given the word code auriculares
#	When I input the entire word code auriculares
#	Then the result should be Felicitaciones Ganaste! =D

Scenario: A single character input
	Given the word code auriculares
	When I input the letter a
	Then the result should be one letter guessed and one letter in the inputs

#Scenario: An entire word input and loose
#	Given the word code auriculares
#	When I input the entire word code casa
#	Then the result should be Que mal, perdiste! D=