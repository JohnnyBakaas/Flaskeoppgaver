namespace Flaskeoppgaver.Model
{
    internal class Bottle
    {
        private int _capasaty;
        private int _content;
        public Bottle(int capasaty)
        {
            _capasaty = capasaty;
        }

        public void Write()
        {
            Console.WriteLine(_content);
        }

        public int GetVolume() { return _content; }

        public void FillFromTap()
        {
            _content = _capasaty;
        }

        public void EmptyBotle()
        { _content = 0; }

        public int CapasatyLeft() { return _capasaty - _content; }

        public bool IsFull() { return _content == _capasaty; }

        public void TransfereContentTo(Bottle bottle)
        {
            int capasatyLeft = bottle.CapasatyLeft();
            if (_content <= capasatyLeft)
            {
                bottle._content += _content;
                _content = 0;
            }
            else if (_content >= capasatyLeft)
            {
                bottle._content += capasatyLeft;
                _content -= capasatyLeft;
            }
        }
    }
}
