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
		/// [4]:(4, 4: "Deuce")
		/// [5]:(1, 0: "Fifteen-Love")
		/// [6]:(0, 1: "Love-Fifteen")
		/// [7]:(2, 0: "Thirty-Love")
		/// [8]:(0, 2: "Love-Thirty")
		/// [9]:(3, 0: "Forty-Love")
		/// [10]:(0, 3: "Love-Forty")
		/// [11]:(4, 0: "Win for player1")
		/// [12]:(0, 4: "Win for player2")
		/// [13]:(2, 1: "Thirty-Fifteen")
		/// [14]:(1, 2: "Fifteen-Thirty")
		/// [15]:(3, 1: "Forty-Fifteen")
		/// [16]:(1, 3: "Fifteen-Forty")
		/// [17]:(4, 1: "Win for player1")
		/// [18]:(1, 4: "Win for player2")
		/// [19]:(3, 2: "Forty-Thirty")
		/// [20]:(2, 3: "Thirty-Forty")
		/// [21]:(4, 2: "Win for player1")
		/// [22]:(2, 4: "Win for player2")
		/// [23]:(4, 3: "Advantage player1")
		/// [24]:(3, 4: "Advantage player2")
		/// [25]:(5, 4: "Advantage player1")
		/// [26]:(4, 5: "Advantage player2")
		/// [27]:(15, 14: "Advantage player1")
		/// [28]:(14, 15: "Advantage player2")
		/// [29]:(6, 4: "Win for player1")
		/// [30]:(4, 6: "Win for player2")
		/// [31]:(16, 14: "Win for player1")
		/// [32]:(14, 16: "Win for player2")
		/// </summary>
		public static string[] score = { "Love-All", "Fifteen-All", "Thirty-All", "Deuce", "Fifteen-Love", "Love-Fifteen", "Thirty-Love", "Love-Thirty", "Forty-Love", "Love-Forty", "Win for player1", "Win for player2", "Thirty-Fifteen", "Fifteen-Thirty", "Forty-Fifteen", "Fifteen-Forty", "Forty-Thirty", "Thirty-Forty", "Win for player1", "Win for player2", "Advantage player1", "Advantage player2" };
	}
}
