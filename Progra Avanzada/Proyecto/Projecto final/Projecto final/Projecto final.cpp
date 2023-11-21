#include <iostream>
#include <string>

// Clase base
class Vehicle {
protected:
    static int idCounter;
    int ID;
    std::string brand;

public:
    Vehicle(const std::string& brand) : brand(brand) {
        ID = idCounter++;
    }

    virtual void getInfo() = 0;  // Función virtual pura
    int getID() const { return ID; }
};

int Vehicle::idCounter = 0;

// Clase derivada: Car
class Car : public Vehicle {
    std::string transmissionType;
    int seatNumber;

public:
    Car(const std::string& brand, const std::string& transmission, int seats)
        : Vehicle(brand), transmissionType(transmission), seatNumber(seats) {}

    void changeTransmission(const std::string& newTransmission) {
        transmissionType = newTransmission;
    }

    void displaySeats() {
        std::cout << "Numero de asientos: " << seatNumber << std::endl;
    }

    void getInfo() override {
        std::cout << "Carro - ID: " << getID() << ", marca: " << brand << std::endl;
    }
};

class Motorcycle : public Vehicle {
    std::string transmissionType;
    int seatNumber;

public:
    Motorcycle(const std::string& brand, const std::string& transmission, int seats)
        : Vehicle(brand), transmissionType(transmission), seatNumber(seats) {}

    void changeTransmission(const std::string& newTransmission) {
        transmissionType = newTransmission;
    }

    void displaySeats() {
        std::cout << "Numero de asientos: " << seatNumber << std::endl;
    }

    void getInfo() override {
        std::cout << "Motocicleta - ID: " << getID() << ", marca: " << brand << std::endl;
    }
};

class Truck : public Vehicle {
    std::string transmissionType;
    int seatNumber;

public:
    Truck(const std::string& brand, const std::string& transmission, int seats)
        : Vehicle(brand), transmissionType(transmission), seatNumber(seats) {}

    void changeTransmission(const std::string& newTransmission) {
        transmissionType = newTransmission;
    }

    void displaySeats() {
        std::cout << "Numero de asientos: " << seatNumber << std::endl;
    }

    void getInfo() override {
        std::cout << "Camion - ID: " << getID() << ", marca: " << brand << std::endl;
    }
};

class Bicycle : public Vehicle {
    std::string transmissionType;
    int seatNumber;

public:
    Bicycle(const std::string& brand, const std::string& transmission, int seats)
        : Vehicle(brand), transmissionType(transmission), seatNumber(seats) {}

    void changeTransmission(const std::string& newTransmission) {
        transmissionType = newTransmission;
    }

    void displaySeats() {
        std::cout << "Numero de asientos: " << seatNumber << std::endl;
    }

    void getInfo() override {
        std::cout << "Bicicleta - ID: " << getID() << ", marca: " << brand << std::endl;
    }
};

class  Bus: public Vehicle {
    std::string transmissionType;
    int seatNumber;

public:
    Bus(const std::string& brand, const std::string& transmission, int seats)
        : Vehicle(brand), transmissionType(transmission), seatNumber(seats) {}

    void changeTransmission(const std::string& newTransmission) {
        transmissionType = newTransmission;
    }

    void displaySeats() {
        std::cout << "Numero de asientos: " << seatNumber << std::endl;
    }

    void getInfo() override {
        std::cout << "Carro - ID: " << getID() << ", marca: " << brand << std::endl;
    }
};


// Clases derivadas: Motorcycle, Truck, Bicycle...
// Implementadas de manera similar a Car

int main() {
    // Crear objetos
    Truck Truck1("Ford", "Manual", 2);
    Car car1("Toyota", "Automatic", 2);
    Motorcycle Moto1("Susuki", "Manual", 2);
    Bus Bus1("Volvo", "Manual", 32);
    Bicycle bici1("Scott", "Manual", 1);
    // ...crear objetos para Motorcycle, Truck, Bicycle

    // Mostrar información
    car1.getInfo();
    Truck1.getInfo();
    Moto1.getInfo();
    Bus1.getInfo();
    bici1.getInfo();
    // ...mostrar información para otros objetos

    return 0;
}