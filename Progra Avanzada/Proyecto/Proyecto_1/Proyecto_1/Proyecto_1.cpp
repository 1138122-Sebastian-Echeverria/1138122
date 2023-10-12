/*/Diego Javier Lemus Girón – 1211621 
Sebastian Echeverria - 1138122/*/

#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <fstream>
#include <filesystem>
#include <fstream>
#include <sstream>
using namespace std;

class Cancion {
public:
    string nombre;
    string artista;
    string duracion;

    Cancion() {}
    Cancion(string _nombre, string _artista, string _duracion) : nombre(_nombre), artista(_artista), duracion(_duracion) {}
};

class CD {
public:
    string nombreCD;
    vector<Cancion> canciones;


};

class Reproductor {
    vector<CD> CDs;
    vector<Cancion> cola;
    Cancion* reproduciendo = nullptr;

public:
    Reproductor() {}
    void cargarRespaldos() {
        cout << "Introduce la ruta de los respaldos (sin espacios, para rutas con espacios, use comillas): ";
        string ruta;
        cin.ignore(); // Limpiar el búfer para getline
        getline(cin, ruta);

        vector<string> archivos = listarArchivos(ruta);
        if (archivos.empty()) {
            cout << "No se encontraron archivos en la ruta especificada." << endl;
            return;
        }

        for (const auto& archivo : archivos) {
            cout << "Procesando archivo: " << archivo << endl; // Mensaje de depuración
            CD cd = cargarCDDesdeArchivo(ruta + "/" + archivo);
            if (!cd.canciones.empty()) {
                CDs.push_back(cd);
                cout << "CD " << cd.nombreCD << " cargado con éxito." << endl; // Mensaje de confirmación
            }
            else {
                cout << "Error al cargar CD desde archivo: " << archivo << endl; // Mensaje de error
            }
        }
    }
    CD cargarCDDesdeArchivo(const string& rutaArchivo) {
        ifstream archivo(rutaArchivo);
        if (!archivo.is_open()) {
            throw runtime_error("No se pudo abrir el archivo " + rutaArchivo);
        }

        CD cd;
        cd.nombreCD = filesystem::path(rutaArchivo).filename().replace_extension().string();

        string linea;
        while (getline(archivo, linea)) {
            size_t posInicio = 0;
            size_t posFin = linea.find("||");

            string nombre, artista, duracion;

            // Verifica si se encontró "||" en la línea
            if (posFin != string::npos) {
                // Extraer nombre
                nombre = linea.substr(posInicio, posFin - posInicio);
                posInicio = posFin + 2;  // Avanzar el índice de inicio más allá de '||'

                // Encontrar la siguiente ocurrencia de '||'
                posFin = linea.find("||", posInicio);

                // Extraer artista
                artista = linea.substr(posInicio, posFin - posInicio);
                posInicio = posFin + 2;  // Avanzar el índice de inicio más allá de '||'

                // Extraer duración
                duracion = linea.substr(posInicio);
            }

            Cancion cancion;
            cancion.nombre = nombre;
            cancion.artista = artista;
            cancion.duracion = duracion;

            cd.canciones.push_back(cancion);
        }

        archivo.close();
        return cd;
    }
    bool formatoValido(const string& linea) {
        int Count = count(linea.begin(), linea.end(), '|');
        return Count == 4 && linea.find("||") != string::npos;
    }
    void mostrarCDs() {
        for (int i = 0; i < CDs.size(); ++i) {
            cout << i + 1 << ". " << CDs[i].nombreCD << endl;
        }
    }

    void agregarCancion() {
        mostrarCDs();
        int eleccion;
        cout << "Seleccione un CD: ";
        cin >> eleccion;
        if (eleccion <= 0 || eleccion > CDs.size()) {
            cout << "Selección no válida." << endl;
            return;
        }

        CD& cdElegido = CDs[eleccion - 1];
        for (int i = 0; i < cdElegido.canciones.size(); ++i) {
            cout << i + 1 << ". " << cdElegido.canciones[i].nombre << endl;
        }
        cout << "Seleccione una canción: ";
        cin >> eleccion;
        if (eleccion <= 0 || eleccion > cdElegido.canciones.size()) {
            cout << "Selección no válida." << endl;
            return;
        }

        cola.push_back(cdElegido.canciones[eleccion - 1]);
        cout << "Canción agregada a la cola." << endl;
    }
    void verColaReproduccion() {
        // Implementar lógica para mostrar la cola de reproducción
        if (cola.empty()) {
            std::cout << "Cola de reproducción vacía." << std::endl;
            return;
        }

        for (const auto& cancion : cola) {
            std::cout << cancion.nombre << " - " << cancion.artista << " - " << cancion.duracion << std::endl;
        }
    }

    void reproducirActual() {
        // Implementar lógica para reproducir la canción actual
        if (reproduciendo) {
            cout << "Reproduciendo: " << reproduciendo->nombre << " - " << reproduciendo->artista << " - " << reproduciendo->duracion << endl;
        }
        else {
            cout << "Reproducción en pausa." << endl;
        }
    }

    void reproducirSiguiente() {
        // Implementar lógica para reproducir la siguiente canción
        if (cola.empty()) {
            cout << "Cola de reproducción vacía." << endl;
            return;
        }

        if (reproduciendo) {
            // Hacer una copia independiente de la canción antes de eliminarla de la cola
            *reproduciendo = cola.front();
        }
        else {
            reproduciendo = new Cancion(cola.front()); // O usa el operador de asignación si está definido
        }

        cola.erase(cola.begin());
    }

    void ordenarCola() {
        // Implementar lógica para ordenar la cola
        cout << "1. Ordenar por artista\n";
        cout << "2. Ordenar por canción\n";
        cout << "3. Ordenar por duración\n";
        int eleccion;
        cin >> eleccion;

        switch (eleccion) {
        case 1:
            sort(cola.begin(), cola.end(), [](const Cancion& a, const Cancion& b) {
                return a.artista < b.artista;
                });
            break;
        case 2:
            sort(cola.begin(), cola.end(), [](const Cancion& a, const Cancion& b) {
                return a.nombre < b.nombre;
                });
            break;
        case 3:
            sort(cola.begin(), cola.end(), [](const Cancion& a, const Cancion& b) {
                return a.duracion < b.duracion;
                });
            break;
        default:
            cout << "Opción no válida." << endl;
            break;
        }
    }
    vector<string> listarArchivos(const string& ruta) {
        vector<string> archivos;

        for (const auto& entry : filesystem::directory_iterator(ruta)) {
            if (entry.is_regular_file() && entry.path().extension() == ".txt") {
                archivos.push_back(entry.path().filename().string());
            }
        }

        return archivos;
    }



};

int main() {
    Reproductor reproductor;

    int opcion = 0;

    do {
        cout << "\n--- Menu ---" << endl;
        cout << "1. Cargar respaldos" << endl;
        cout << "2. Agregar Cancion" << endl;
        cout << "3. Ver Cola de Reproduccion" << endl;
        cout << "4. Ordenar Cola de Reproduccion" << endl;
        cout << "5. Reproducir Cancion Actual" << endl;
        cout << "6. Reproducir Siguiente Cancion" << endl;
        cout << "7. Salir" << endl;

        cout << "Seleccione una opcion: ";
        while (!(cin >> opcion)) {
            cout << "Por favor, ingrese un número válido: ";
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
        }

        switch (opcion) {
        case 1:
            reproductor.cargarRespaldos();
            break;
        case 2:
            reproductor.agregarCancion();
            break;
        case 3:
            reproductor.verColaReproduccion();
            break;
        case 4:
            reproductor.ordenarCola();
            break;
        case 5:
            reproductor.reproducirActual();
            break;
        case 6:
            reproductor.reproducirSiguiente();
            break;
        case 7:
            break;
        default:
            cout << "Opción no válida. Por favor, intente nuevamente." << endl;
            break;
        }

        // Pausar y esperar que el usuario presione enter para continuar
        cout << "\nPresione ENTER para continuar...";
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        cin.get();

    } while (opcion != 7);

    return 0;
}

