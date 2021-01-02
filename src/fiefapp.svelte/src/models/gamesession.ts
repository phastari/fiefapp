import type { Inheritance } from './inheritance';
import type { Livingcondition } from './livingcondition';
import type { Road } from './road';

interface IGamesession {
  id: string;
  ownerId: string;
  userIds: string[];
  gamemasterId: string;
  playerIds: string[];
  name: string;
  inheritances: Inheritance[];
  roads: Road[];
  livingconditions: Livingcondition[];
}

export class Gamesession implements IGamesession {
  id: string;
  ownerId: string;
  userIds: string[];
  gamemasterId: string;
  playerIds: string[];
  name: string;
  inheritances: Inheritance[];
  roads: Road[];
  livingconditions: Livingcondition[];

  constructor() {
    this.id = '';
    this.ownerId = '';
    this.userIds = [];
    this.gamemasterId = '';
    this.playerIds = [];
    this.name = '';
    this.inheritances = [];
    this.roads = [];
    this.livingconditions = [];
  }
}
