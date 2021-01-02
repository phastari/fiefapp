interface IBoat {
  id: string;
  boatbuilderId?: string;
  cargoId?: string;
  shipyardId?: string;
  soldierIds: string[];
  name: string;
  length: number;
  width: number;
  depth: number;
  crewNeeded: number;
  seamens: number;
  mariners: number;
  rowers: number;
  rowersNeeded: number;
  maxCargo: number;
  sailors: number;
  officers: number;
  navigators: number;
  amount: number;
  costWhenFinishedSilver: number;
  nextFinishedDays: number;
  buildTimeInDays: number;
  buildTimeInDaysAll: number;
  status: string;
  backInDays: number;
  type: BoatType;
  displayName: string;
  masts: number;
  lengthMin: number;
  lengthMax: number;
  bl: number;
  db: number;
  crew: number;
  benchMod: number;
  benchMulti: number;
  oarsMulti: number;
  rowerMulti: number;
  seaworthiness: number;
  imgSource: string;
}

export class Boat implements IBoat {
  id: string;
  boatbuilderId?: string;
  cargoId?: string;
  shipyardId?: string;
  soldierIds: string[];
  name: string;
  length: number;
  width: number;
  depth: number;
  crewNeeded: number;
  seamens: number;
  mariners: number;
  rowers: number;
  rowersNeeded: number;
  maxCargo: number;
  sailors: number;
  officers: number;
  navigators: number;
  amount: number;
  costWhenFinishedSilver: number;
  nextFinishedDays: number;
  buildTimeInDays: number;
  buildTimeInDaysAll: number;
  status: string;
  backInDays: number;
  type: BoatType;
  displayName: string;
  masts: number;
  lengthMin: number;
  lengthMax: number;
  bl: number;
  db: number;
  crew: number;
  benchMod: number;
  benchMulti: number;
  oarsMulti: number;
  rowerMulti: number;
  seaworthiness: number;
  imgSource: string;

  constructor(boatType: BoatType, shipyardId?: string) {
    this.id = '';
    this.boatbuilderId = undefined;
    this.cargoId = undefined;
    this.shipyardId = shipyardId;
    this.soldierIds = [];
    this.name = '';
    this.length = 0;
    this.width = 0;
    this.depth = 0;
    this.crewNeeded = 0;
    this.seamens = 0;
    this.mariners = 0;
    this.rowers = 0;
    this.rowersNeeded = 0;
    this.maxCargo = 0;
    this.sailors = 0;
    this.officers = 0;
    this.navigators = 0;
    this.amount = 0;
    this.costWhenFinishedSilver = 0;
    this.nextFinishedDays = 0;
    this.buildTimeInDays = 0;
    this.buildTimeInDaysAll = 0;
    this.status = '';
    this.backInDays = 0;
    this.type = boatType;
    this.displayName = '';
    this.masts = 0;
    this.lengthMin = 0;
    this.lengthMax = 0;
    this.bl = 0;
    this.db = 0;
    this.crew = 0;
    this.benchMod = 0;
    this.benchMulti = 0;
    this.oarsMulti = 0;
    this.rowerMulti = 0;
    this.seaworthiness = 0;
    this.imgSource = '';
  }
}

export enum BoatType {
  UNDEFINED = 0,
  FISHING_BOAT = 1,
}
