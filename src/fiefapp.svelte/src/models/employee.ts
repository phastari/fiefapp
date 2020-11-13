import { v4 as uuidv4 } from 'uuid';

import type { IPerson } from './person';

interface IEmployee {
  type: EmployeeType;
}

export enum EmployeeType {
  FALCONER = 'FALCONER',
  BAILIFF = 'BAILIFF',
  HERALD = 'HERALD',
  HUNTER = 'HUNTER',
  PHYSICIAN = 'PHYSICIAN',
  SCHOLAR = 'SCHOLAR',
  CUPBEARER = 'CUPBEARER',
  PROSPECTOR = 'PROSPECTOR',
}

export class Employee implements IEmployee, IPerson {
  readonly id: string;
  type: EmployeeType;
  name: string;
  skill: number;
  resources: number;
  loyalty: number;
  age: number;

  constructor(type: EmployeeType) {
    this.id = uuidv4();
    this.type = type;
    this.name = '';
    this.skill = 0;
    this.resources = 0;
    this.loyalty = 0;
    this.age = 0;
  }
}
