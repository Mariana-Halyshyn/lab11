using System;

namespace KompleksneChysloApp
{
    public class Strichka
    {
        protected string _text;
        protected byte _length;
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                _length = (byte)(System.Text.Encoding.UTF8.GetByteCount(_text));
            }
        }

        //Довжина
        public byte Length => _length;

       
        public Strichka()
        {
            Text = string.Empty;
        }

        // Рядки
        public Strichka(string text)
        {
            Text = text;
        }

        // Конструктор із символом
        public Strichka(char character)
        {
            Text = character.ToString();
        }

        // Метод для очищення стрічки
        public void Clear()
        {
            Text = string.Empty;
        }

        // отримання довжини стрічки
        public byte GetLength()
        {
            return Length;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}


