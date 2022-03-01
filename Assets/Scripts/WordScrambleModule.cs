using System.Collections.Generic;
using UnityEngine;

public class WordScrambleModule : WordModule {
	private string _solution;

	private static readonly IList<string> Words = new List<string>()
	{
		"answer",
		"archer",
		"attack",
		"banana",
		"beauty",
		"belief",
		"blasts",
		"bursts",
		"button",
		"cannon",
		"casing",
		"charge",
		"column",
		"copper",
		"damage",
		"danger",
		"defuse",
		"device",
		"disarm",
		"energy",
		"escape",
		"expert",
		"failed",
		"flames",
		"forced",
		"health",
		"injury",
		"kaboom",
		"kevlar",
		"keypad",
		"launch",
		"legacy",
		"letter",
		"manual",
		"marine",
		"marked",
		"minute",
		"module",
		"mortar",
		"napalm",
		"number",
		"ottawa",
		"people",
		"permit",
		"person",
		"police",
		"prison",
		"reduce",
		"remote",
		"robots",
		"rocket",
		//"sapper",
		"second",
		"semtex",
		"signal",
		"stress",
		"strike",
		"struck",
		"submit",
		"switch",
		"symbol",
		"system",
		"target",
		"threat",
		"timing",
		"unique",
		"update",
		"victim",
		"weapon",
		"widget",
		"wiring"
	};

	void Start () {
		Init();
	}

	void Init()
	{
		var wordIndex = Random.Range(0, Words.Count);
		_solution = Words[wordIndex];
		Answer = string.Empty;

		Puzzle = ScrambleWord(_solution);
		SetAnswerDisplay(string.Empty);
		SetPuzzleDisplay(Puzzle);
		SetUpButtons();
	}

	protected override bool Solve()
	{
		return Answer.Equals(_solution);
	}
}
