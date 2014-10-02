using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    class Monopoly
    {
        // Store number of players in the game
        public int m_Players;
        // Input handling class to parse user input
        Input m_InputHandler;
        // Store the current roll result
        public int m_Die1, m_Die2;
        private Player[] m_Pieces;
        public Monopoly() 
        {
            m_Players = 0;
            m_InputHandler = new Input();
            m_Pieces = new Player[4];
            m_Pieces[0] = new LukeSkywalker();
            m_Pieces[1] = new DarthVader();
            m_Pieces[2] = new Chewie();
            m_Pieces[3] = new BobaFett();
        }

        // Introduce the players and get number of players
        public void Intro()
        {
            // Welcome to players and ask them to enter the number of players
            Console.WriteLine(" :-: Welcome to Monopoly!");
            Console.WriteLine(" :?: How many people are playing today?");
            Console.WriteLine(" :-: (1, 2, 3, or 4) ");
            Console.Write(" > ");
            string input = Console.ReadLine();
            // Pass the current input into the input handler to check for a matching in value
            m_Players = m_InputHandler.SetIntValue(input);
            // While players still = 0 we have not set a value
            while (m_Players == 0)
            {
                // Continue to ask the user for a # between 1-4 until players is set properly
                Console.WriteLine(" :!: Please only enter a number between 1-4.");
                Console.Write(" > ");
                input = Console.ReadLine();
                m_Players = m_InputHandler.SetIntValue(input);
            }
            
        }
        // Ask the players to pick their pieces
        public void Setup()
        {
            Console.Clear();
            // Inform player we are going to select pieces
            Console.WriteLine(" :-: Great! We have " + m_Players + " players today.");
            Console.WriteLine(" :-: Next we need to pick our pieces."); 
            // Get number of pieces in our pieces array
            int pieceCount = m_Pieces.Length;
            // Iterate through each player, asking them to select a piece
            for (int i = 0; i < m_Players; i++)
            {
                Console.WriteLine(" :?: Player " + (i + 1) + ", choose your piece.");
                // Iterate through each piece and inform player if it is an eligible choice
                // Providing a number to input to select a given piece as well
                for (int j = 0; j < pieceCount; j++)
                {
                    if (m_Pieces[j].position == -1)
                    {
                        Console.WriteLine(" :Piece: Enter " + (j + 1) + " to select " + m_Pieces[j].name + ".");
                    }
                    else
                    {
                        Console.WriteLine(" :Player " + m_Pieces[j].GetPlayer()  +" : Selected " + m_Pieces[j].name + ".");
                    }
                }
                // Loop through an input check while we wait on proper input to set a player choice to a matching value
                int pieceChoice = 0;
                while (pieceChoice == 0)
                {
                    Console.Write(" > ");
                    pieceChoice = m_InputHandler.SetIntValue(Console.ReadLine());
                    if (pieceChoice == 0)
                    {
                        Console.WriteLine(" :!: Please enter a value between 1-4.");
                    }
                    else if (m_Pieces[pieceChoice-1].position != -1)
                    {
                        Console.WriteLine(" :!: That piece was already selected by Player " + m_Pieces[pieceChoice-1].GetPlayer() + "!");
                        pieceChoice = 0;
                    }
                    else
                    {
                        Console.WriteLine(" :^: You selected " + m_Pieces[pieceChoice-1].name + ".");
                        m_Pieces[pieceChoice-1].SetPlayer(i + 1);
                    }
                }
                Console.Clear();
            }
        }
        // Game play method - should loop till completion
        public void GamePlay()
        {
            // Inform player we are going to select pieces
            Console.WriteLine(" :-: Time to start playing.");
            Console.WriteLine(" :-: On your turn, press R to roll (and move).");
            Console.WriteLine(" :-: Press A to choose an action such as buying houses or trading.");
            bool gameOver = false;
            int currentPlayer = 1;
            ConsoleKeyInfo cki;
            while (!gameOver)
            {
                Console.Write(" Player " + (currentPlayer) + " > ");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.R)
                {
                    Roll();
                    m_Pieces[currentPlayer - 1].Move((m_Die1+m_Die2));
                    m_Pieces[currentPlayer - 1].Speech();
                    currentPlayer++;
                    if (currentPlayer > m_Players)
                         currentPlayer = 1;
                }
                else if (cki.Key == ConsoleKey.A)
                {
                    // open options menu
                }
                else
                {
                    Console.WriteLine(" :!: Please press R or A. ");
                }
            }
        }
        // Roll the dice, store the result
        public void Roll()
        {
            Random rnd = new Random();
            m_Die1 = rnd.Next(1,6);
            m_Die2 = rnd.Next(1,6);
            Console.WriteLine("\n :Dice: You rolled > " + m_Die1 + " and " + m_Die2 + "!");
        }
    }
}
