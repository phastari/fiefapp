import type { Building } from './building';
import type { IPerson } from './person';

interface IBuilder {
  building?: Building;
}

export class Builder implements IBuilder, IPerson {
  id: string;
  building?: Building;
  name: string;
  skill: number;
  resources: number;
  loyalty: number;
  age: number;

  constructor() {
    this.id = '';
    this.building = undefined;
    this.name = '';
    this.skill = 0;
    this.resources = 0;
    this.loyalty = 0;
    this.age = 0;
  }
}
