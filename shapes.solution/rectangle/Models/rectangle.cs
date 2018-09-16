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
			return _length;
		}

		public void SetLength(int newLength)
		{
			newLength = _length;
		}

		public int GetWidth()
		{
			return _width;
		}

		public void SetWidth(int newWidth)
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