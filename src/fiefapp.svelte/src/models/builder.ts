import { v4 as uuidv4 } from 'uuid';

import type { IPerson } from './person';

interface IBuilder {
  buildingId?: string;
}

export class Builder implements IBuilder, IPerson {
  readonly id: string;
  buildingId?: string;
  name: string;
  skill: number;
  resources: number;
  loyalty: number;
  age: number;

  constructor() {
    this.id = uuidv4();
    this.buildingId = undefined;
    this.name = '';
    this.skill = 0;
    this.resources = 0;
    this.loyalty = 0;
    this.age = 0;
  }
}
