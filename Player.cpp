#include "Map.h"
#include "Objects.h"

void PlayerMove() {
	char Key = 0;
	DrawMap();
	while (Key != 'q') {
		Key = std::cin.get();


		if (Key == 'w') {
			if (map[PlayerObj.y][PlayerObj.x] != map[EnemyObj.y][EnemyObj.x]) {
				map[PlayerObj.y][PlayerObj.x] = '#';
			}

			if (!isEnemyPosition(PlayerObj.x, PlayerObj.y - 1)) {
				--PlayerObj.y;
			}

		}
		else if (Key == 'a') {
			if (map[PlayerObj.y][PlayerObj.x] != map[EnemyObj.y][EnemyObj.x]) {
				map[PlayerObj.y][PlayerObj.x] = '#';
			}

			if (!isEnemyPosition(PlayerObj.x - 1, PlayerObj.y)) {
				--PlayerObj.x;
			}

		}
		else if (Key == 's') {
			if (map[PlayerObj.y][PlayerObj.x] != map[EnemyObj.y][EnemyObj.x]) {
				map[PlayerObj.y][PlayerObj.x] = '#';
			}

			if (!isEnemyPosition(PlayerObj.x, PlayerObj.y + 1)) {
				++PlayerObj.y;
			}

		}
		else if (Key == 'd') {
			if (map[PlayerObj.y][PlayerObj.x] != map[EnemyObj.y][EnemyObj.x]) {
				map[PlayerObj.y][PlayerObj.x] = '#';
			}

			if (!isEnemyPosition(PlayerObj.x + 1, PlayerObj.y)) {
				++PlayerObj.x;
			}

		}
		system("cls");
		if (map[PlayerObj.y][PlayerObj.x] != map[EnemyObj.y][EnemyObj.x]) {
			map[PlayerObj.y][PlayerObj.x] = 'P';
		}
		//isEnemyPosition(PlayerObj.y, PlayerObj.x);
		DrawMap();
	}
}



