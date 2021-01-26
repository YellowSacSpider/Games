#ifndef ENEMY_H
#define ENEMY_H

struct Enemy {
	int x = 3;
	int y = 3;
	bool isAlive = true;
};


bool isEnemyPosition(int x, int y);
#endif
