#include "Collisions.h"
#include "Objects.h"
#include "Map.h"

bool isEnemyPosition(int x, int y) {
	if (x == EnemyObj.x && y == EnemyObj.y && EnemyObj.isAlive) {
		std::cout << "Collided with Enemy!\n";
		map[EnemyObj.y][EnemyObj.x] = 'E';
		return true;
	}
	return false;
}