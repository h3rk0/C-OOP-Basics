﻿using System;
using System.Collections.Generic;
using System.Text;


public interface IAnimal
{
	string Name { get; }
	string FavouriteFood { get; }

	string ExplainSelf();
}

