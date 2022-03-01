using System.Collections.Generic;
using UnityEngine;

public class AnagramsModule : WordModule
{
	private static readonly IList<IList<string>> Words = new List<IList<string>>()
	{
		new List<string> {"actors", "costar", "castor"},
		new List<string> {"airmen", "marine", "remain"},
		new List<string> {"antler", "learnt", "rental"},
		new List<string> {"arches", "chaser", "search"},
		new List<string> {"artist", "strait", "traits"},
		new List<string> {"ascent", "secant", "stance"},
		new List<string> {"asleep", "elapse", "please"},
		new List<string> {"assert", "asters", "stares"},
		new List<string> {"barely", "barley", "bleary"},
		new List<string> {"bleats", "stable", "tables"},
		new List<string> {"caller", "cellar", "recall"},
		new List<string> {"corset", "escort", "sector"},
		new List<string> {"dearth", "hatred", "thread"},
		new List<string> {"deltas", "lasted", "slated"},
		new List<string> {"denter", "rented", "tender"},
		new List<string> {"desert", "deters", "rested"},
		new List<string> {"detour", "routed", "toured"},
		new List<string> {"diaper", "paired", "repaid"},
		new List<string> {"direst", "driest", "stride"},
		new List<string> {"doters", "sorted", "stored"},
		new List<string> {"duster", "rusted", "rudest"},
		new List<string> {"earned", "endear", "neared"},
		new List<string> {"emoter", "meteor", "remote"},
		new List<string> {"endive", "envied", "veined"},
		new List<string> {"filets", "itself", "stifle"},
		new List<string> {"filter", "lifter", "trifle"},
		new List<string> {"gilder", "girdle", "glider"},
		new List<string> {"ideals", "ladies", "sailed"},
		new List<string> {"lemons", "melons", "solemn"},
		new List<string> {"lisper", "perils", "pliers"},
		new List<string> {"livers", "silver", "sliver"},
		new List<string> {"looped", "poodle", "pooled"},
		new List<string> {"master", "stream", "tamers"},
		new List<string> {"paltry", "partly", "raptly"},
		new List<string> {"rashes", "shears", "shares"},
		new List<string> {"rescue", "secure", "recuse"},
		new List<string> {"resort", "roster", "sorter"},
		new List<string> {"seated", "sedate", "teased"},
		new List<string> {"skated", "staked", "tasked"},
		new List<string> {"slates", "steals", "tassel"},
		new List<string> {"taster", "tetras", "treats"},
		new List<string> {"whiter", "wither", "writhe"}
	};

	private IList<string> _solution;

	void Start()
	{
		Init();
	}

	private void Init()
	{
		SetUpPuzzle();
		SetAnswerDisplay(string.Empty);
		SetPuzzleDisplay(Puzzle);
		SetUpButtons();
	}

	private void SetUpPuzzle()
	{
		var puzzleKey = Random.Range(0, Words.Count);
		var wordList = Words[puzzleKey];
		var puzzleChoice = Random.Range(0, wordList.Count);

		Puzzle = wordList[puzzleChoice];
		_solution = new List<string>();

		for (var i = 0; i < wordList.Count; i++)
		{
			if (i != puzzleChoice)
				_solution.Add(wordList[i]);
		}
	}

	protected override bool Solve()
	{
		return _solution.Contains(Answer);
	}
}
