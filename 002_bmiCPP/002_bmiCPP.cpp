﻿#include <iostream>
using namespace std;

int main()
{
    double h, w;

    cout << "키(cm) : ";
    cin >> h;

    cout << "체중(kg) : ";
    cin >> w;

    h /= 100;

    double bmi = w / (h * h);
    cout << "BMI = " << bmi << endl;
}