//Ivelina Hristova Hristova
//61644, grupa 5, domashno 1
//17.01.2013, задачата е пълна; Резултатът е оформен във вид на таблица.
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    cout<<"Ivelina Hristova Hristova, grupa 5, fn: 61644\nDomashna rabota nomer 1\n";
    int startX=50, startY=50,  step=5, maxX=300, maxY=200,endX,endY,count=0;
    endX=startX;
    endY=startY;
    cout<<"Otsechka ---- x1 ----- y1 ----- x2 ----- y2\n\n";
    while(startX>0 && startX<maxX && startY>0 && startY<maxY && endX>0 && endX<maxX && endY>0 && endY<maxY)
    {


    switch(count%4)
    {
        case 0:

        endY=endY-step; break;
        case 1:
        endX=startX+(step); break;
        case 2:

        endY=startY+(2*step); break;
        case 3:
        endX=startX-(2*step);
         break;

    }

    cout<<setw(5)<<count+1<<setw(10)<<startX<<setw(10)<<startY<<setw(10)<<endX<<setw(10)<<endY<<endl;
    count++;
    startX=endX;
    startY=endY;
    }


    return 0;
}
