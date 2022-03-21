using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class FoodCreator // класс подпрограмм для создания "еды" для змейки
	{
		int mapWidht;
		int mapHeight;
		char sym;

		Random random = new Random( ); 

		public FoodCreator(int mapWidth, int mapHeight, char sym) //конструктор который приравнивает значения
		{
			this.mapWidht = mapWidth;
			this.mapHeight = mapHeight;
			this.sym = sym;
		}

		public Point CreateFood() // метод для создания еды в рандомном месте
		{
			int x = random.Next( 2, mapWidht - 2 );
			int y = random.Next( 2, mapHeight - 2 );
			return new Point( x, y, sym );
		}
	}
}
