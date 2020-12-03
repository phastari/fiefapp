import { v4 as uuidv4 } from 'uuid';

interface IGamesession {
  gamesessionId: string;
  ownerId: string;
  userIds: string[];
  gamemasterId: string | undefined;
  playerIds: string[];
  name: string;
}

export class Gamesession implements IGamesession {
  readonly gamesessionId: string;
  userIds: string[];
  gamemasterId: string | undefined;
  playerIds: string[];
  name: string;

  constructor(public ownerId: string) {
    this.gamesessionId = uuidv4();
    this.userIds = [ownerId];
    this.gamemasterId = undefined;
    this.playerIds = [];
    this.name = 'Ny spelsession';
  }
}
