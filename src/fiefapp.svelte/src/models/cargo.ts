interface ICargo {
  id: string;
  silver: number;
  base: number;
  luxury: number;
  wood: number;
  iron: number;
  stone: number;
  other: number;
  otherInformation: string;
}

export class Cargo implements ICargo {
  id: string;
  silver: number;
  base: number;
  luxury: number;
  wood: number;
  iron: number;
  stone: number;
  other: number;
  otherInformation: string;

  constructor() {
    this.id = '';
    this.silver = 0;
    this.base = 0;
    this.luxury = 0;
    this.wood = 0;
    this.iron = 0;
    this.stone = 0;
    this.other = 0;
    this.otherInformation = '';
  }
}
