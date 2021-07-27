namespace Tennis
{
    public class GlobalVariables
    {
		/// <summary>
		/// Possible scores for tennis:
		/// [0]:(0,  0: "Love-All")
		/// [1]:(1, 1: "Fifteen-All")
		/// [2]:(2, 2: "Thirty-All")
		/// [3]:(3, 3: "Deuce")
		/// [3]:(4, 4: "Deuce")
		/// [4]:(1, 0: "Fifteen-Love")
		/// [5]:(0, 1: "Love-Fifteen")
		/// [6]:(2, 0: "Thirty-Love")
		/// [7]:(0, 2: "Love-Thirty")
		/// [8]:(3, 0: "Forty-Love")
		/// [9]:(0, 3: "Love-Forty")
		/// [16]:(4, 0: "Win for player 1")
		/// [17]:(0, 4: "Win for player 2")
		/// [10]:(2, 1: "Thirty-Fifteen")
		/// [11]:(1, 2: "Fifteen-Thirty")
		/// [12]:(3, 1: "Forty-Fifteen")
		/// [13]:(1, 3: "Fifteen-Forty")
		/// [16]:(4, 1: "Win for player 1")
		/// [17]:(1, 4: "Win for player 2")
		/// [14]:(3, 2: "Forty-Thirty")
		/// [15]:(2, 3: "Thirty-Forty")
		/// [16]:(4, 2: "Win for player 1")
		/// [17]:(2, 4: "Win for player 2")
		/// [18]:(4, 3: "Advantage player 1")
		/// [19]:(3, 4: "Advantage player 2")
		/// [18]:(5, 4: "Advantage player 1")
		/// [19]:(4, 5: "Advantage player 2")
		/// [18]:(15, 14: "Advantage player 1")
		/// [19]:(14, 15: "Advantage player 2")
		/// [16]:(6, 4: "Win for player 1")
		/// [17]:(4, 6: "Win for player 2")
		/// [16]:(16, 14: "Win for player 1")
		/// [17]:(14, 16: "Win for player 2")
		/// </summary>
		public static string[] score = { "Love-All", "Fifteen-All", "Thirty-All", "Deuce", "Fifteen-Love", "Love-Fifteen", "Thirty-Love", "Love-Thirty", "Forty-Love", "Love-Forty", "Thirty-Fifteen", "Fifteen-Thirty", "Forty-Fifteen", "Fifteen-Forty", "Forty-Thirty", "Thirty-Forty", "Win for player 1", "Win for player 2", "Advantage player 1", "Advantage player 2" };
	}
}
