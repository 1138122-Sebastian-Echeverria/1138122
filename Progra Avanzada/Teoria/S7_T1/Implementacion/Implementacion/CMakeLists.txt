cmake_minimum_required(VERSION 3.26)
project(Implementacion)

set(CMAKE_CXX_STANDARD 17)

add_executable(Implementacion main.cpp
        Nodo.cpp
        Nodo.h
        Lista.cpp
        Lista.h
        Cola.cpp
        Cola.h)
