﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorizontalLine : Figure //наследственный класс
	{
		public HorizontalLine(int xLeft, int xRight, int y, char sym) //функуция для создания левой и правой игрового поля игры
		{
			pList = new List<Point>();
			for(int x = xLeft; x <= xRight; x++)
			{
				Point p = new Point( x, y, sym );
				pList.Add( p );
			}			
		}
	}
}
