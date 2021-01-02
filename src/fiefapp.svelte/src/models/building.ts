import type { Builder } from './builder';

interface IBuilding {
  id: string;
  builderId?: string;
  type: string;
  amount: number;
  woodworkThisYear: number;
  stoneworkThisYear: number;
  smithsworkThisYear: number;
  woodThisYear: number;
  stoneThisYear: number;
  ironThisYear: number;
  upkeep: number;
  woodwork: number;
  stonework: number;
  smithswork: number;
  wood: number;
  stone: number;
  iron: number;
}

export class Building implements IBuilding {
  id: string;
  builder?: Builder;
  amount: number;
  woodworkThisYear: number;
  stoneworkThisYear: number;
  smithsworkThisYear: number;
  woodThisYear: number;
  stoneThisYear: number;
  ironThisYear: number;
  type: string;
  upkeep: number;
  woodwork: number;
  stonework: number;
  smithswork: number;
  wood: number;
  stone: number;
  iron: number;

  constructor() {
    this.id = '';
    this.builder = undefined;
    this.amount = 0;
    this.woodworkThisYear = 0;
    this.stoneworkThisYear = 0;
    this.smithsworkThisYear = 0;
    this.woodThisYear = 0;
    this.stoneThisYear = 0;
    this.ironThisYear = 0;
    this.type = '';
    this.upkeep = 0;
    this.woodwork = 0;
    this.stonework = 0;
    this.smithswork = 0;
    this.wood = 0;
    this.stone = 0;
    this.iron = 0;
  }
}
