float csharp4 = 277.18f;
float d4 = 293.66f;
float dsharp4 = 311.13f;
float e4 = 329.63f;
float f4 = 349.23f;
float fsharp4 = 369.99f;
float g4 = 392.00f;
float gsharp4 = 415.30f;
float a4 = 440.00f;
float asharp4 = 466.16f;
float b4 = 493.88f;
float c5 = 523.25f;
float csharp5 = 554.37f;
float f5 = 698.46f;
float fsharp5 = 739.99f;

// This only works for 4/4 time signature
int bpm = 128;
float millisecondsPerBeat = 60000f / (float)bpm;

float wholeNote = millisecondsPerBeat * 4;
float halfNote = millisecondsPerBeat * 2;
float quarterNote = millisecondsPerBeat * 1;
float eighthNote = millisecondsPerBeat / 2;
float sixteenthNote = millisecondsPerBeat / 4;
float dottedQuarterNote = quarterNote + eighthNote;

Console.WriteLine("Press any key to play Sweet Child O' Mine");
bool keyPressed = false;
Console.ReadKey(true);
keyPressed = true;
if (keyPressed == true)
{
    PlaySweetChildOMine();
    keyPressed = false;
}


void PlaySweetChildOMine()
{
    // BAR ONE
    Console.Beep((int)csharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR TWO
    Console.Beep((int)csharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR THREE
    Console.Beep((int)dsharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR FOUR
    Console.Beep((int)dsharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR FIVE
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR SIX
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR SEVEN
    Console.Beep((int)csharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR EIGHT
    Console.Beep((int)csharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR NINE
    Console.Beep((int)dsharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR TEN
    Console.Beep((int)dsharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR ELEVEN
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);

    // BAR TWELVE
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)csharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)fsharp4, (int)eighthNote);
    Console.Beep((int)fsharp5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
    Console.Beep((int)f5, (int)eighthNote);
    Console.Beep((int)gsharp4, (int)eighthNote);
}