namespace shapes.Models
{
	public class Rectangle
	{
		private int _length;
		private int _width;

		public Rectangle(int sideWidth, int sideLength)
		{
			_length = sideLength;
			_width = sideWidth;
		}

		public int GetLength()
		{
			return Length;
		}

		public void SetLength(newLength)
		{
			newLength = _length;
		}

		public int GetWidth()
		{
			return width;
		}

		public void SetWidth(newWidth)
		{
			newWidth = _width;
		}	
		
		public int GetArea()
		{
			return _length * _width;
		}

		public bool IsSquare()
		{
			if(_length == _width)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

}