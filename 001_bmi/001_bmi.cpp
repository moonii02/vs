#include <stdio.h>

int main()
{
    // 키와 체중을 입력받아서, bmi를 계산하고, 출력
    double h; // 키
    double w; // 체중

    printf("키(cm) : ");
    scanf_s("%lf", & h);

    printf("체중(kg) : ");
    scanf_s("%lf", & w);

    h /= 100; // 미터(m)로 환산

    double bmi = w / (h * h);
    printf("BMI = %.2lf\n", bmi);
}
