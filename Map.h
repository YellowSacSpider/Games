#ifndef MAP_H
#define MAP_H
#include <iostream>

constexpr int MAP_SIZE = 8;
extern char map[MAP_SIZE][MAP_SIZE];


void InitMap();
void DrawMap();
#endif