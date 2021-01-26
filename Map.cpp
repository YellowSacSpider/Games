#include "Map.h"
#include "Objects.h"


char map[MAP_SIZE][MAP_SIZE] = { 0 };

void InitMap() {
	for (int i = 0; i < MAP_SIZE; i++) {
		for (int j = 0; j < MAP_SIZE; j++) {
			map[i][j] = '#';
		}
	}
	map[MAP_SIZE / 2][MAP_SIZE / 2] = 'P';
	map[EnemyObj.y][EnemyObj.x] = 'E';
}

void DrawMap() {
	for (int i = 0; i < MAP_SIZE; i++) {
		for (int j = 0; j < MAP_SIZE; j++) {
			std::cout << map[i][j];
		}
		std::cout << '\n';
	}
}