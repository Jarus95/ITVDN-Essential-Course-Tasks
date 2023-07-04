namespace _3_Task1
{
    public class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(params Pupil[] _pupils)
        {
            pupils = new Pupil[_pupils.Length];
            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i] = _pupils[i];
            }


        }

        public void Study()
        {
            for (int i = 0; i < pupils.Length; i++)
            {

                pupils[i].Study();
            }
        }

        public void Relax()
        {
            for (int i = 0; i < pupils.Length; i++)
            {

                pupils[i].Relax();

            }
        }

        public void Write()
        {
            for (int i = 0; i < pupils.Length; i++)
            {

                pupils[i].Write();
            }
        }


        public void Read()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i].Read();

            }
        }
    }
}
