import type { IPerson } from './person';

interface IEmployee {
  type: EmployeeType;
}

export enum EmployeeType {
  UNDEFINED = 0,
  FALCONER = 1,
  BAILIFF = 2,
  HERALD = 3,
  HUNTER = 4,
  PHYSICIAN = 5,
  SCHOLAR = 6,
  CUPBEARER = 7,
  PROSPECTOR = 8,
}

export class Employee implements IEmployee, IPerson {
  id: string;
  type: EmployeeType;
  name: string;
  skill: number;
  resources: number;
  loyalty: number;
  age: number;

  constructor() {
    this.id = '';
    this.type = EmployeeType.UNDEFINED;
    this.name = '';
    this.skill = 0;
    this.resources = 0;
    this.loyalty = 0;
    this.age = 0;
  }
}
