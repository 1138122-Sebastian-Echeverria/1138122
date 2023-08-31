#include <iostream>
using namespace std;

class Pixel
{
public:

    int* color;

    Pixel(int* colorPtr) {
        color = colorPtr;
    }

    void setColorRojo(int rojo) {
        if (rojo >= 0 && rojo <= 255) {
            color[0] = rojo;
        }
    }

    void setColorVerde(int verde) {
        if (verde >= 0 && verde <= 255) {
            color[1] = verde;
        }
    }

    void setColorAzul(int azul) {
        if (azul >= 0 && azul <= 255) {
            color[2] = azul;
        }
    }

    float* aPorcentajeColor() {
        float* porcentajeColor = new float[3];

        for (int i = 0; i < 3; ++i) {
            porcentajeColor[i] = static_cast<float>(color[i]) / 255.0f;
        }

        return porcentajeColor;
    }
};

int main() {
    int color[3];
    Pixel pixel(color);

    pixel.setColorRojo(123);
    pixel.setColorVerde(123);
    pixel.setColorAzul(123);

    float* porcentajeColor = pixel.aPorcentajeColor();
    cout << "Pixel = [" << color[0] << ", " << color[1] << ", " << color[2] << "]" << endl;
    cout << "Porcentaje de color = [" << porcentajeColor[0] << ", " << porcentajeColor[1] << ", " << porcentajeColor[2] << "]" << std::endl;

    delete[] porcentajeColor;

    return 0;
}
