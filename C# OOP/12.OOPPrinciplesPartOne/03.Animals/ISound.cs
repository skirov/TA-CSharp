using System;

namespace Animals
{
    interface ISound
    {
        string Sound { get; } //if you know why this is bad practice, please explain it to me in the comment :)
        void ProduceSound(string sound);
    }
}
