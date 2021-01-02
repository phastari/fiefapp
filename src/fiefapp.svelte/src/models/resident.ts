import type { IPerson } from './person';

interface IResident {
  information: string;
}

export class Resident implements IResident, IPerson {
  id: string;
  name: string;
  age: number;
  resources: number;
  loyalty: number;
  skill: number;
  information: string;

  constructor() {
    this.id = '';
    this.name = '';
    this.age = 0;
    this.resources = 0;
    this.skill = 0;
    this.loyalty = 0;
    this.information = '';
  }
}
