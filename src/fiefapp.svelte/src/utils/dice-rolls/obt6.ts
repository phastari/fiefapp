export interface DiceRoll {
  rolls: number[];
  total: number;
}

export const rollObt6 = (dice: number = 1, mod: number = 0) => {
  let rolls: number[] = [];
  let total = 0;
  for (let i = 0; i < dice; i++) {
    let roll = Math.floor(Math.random() * 6) + 1;
    rolls.push(roll);

    if (roll === 6) {
      dice += 2;
      continue;
    }

    total += roll;
  }

  return {
    rolls: rolls,
    total: total + mod,
  };
};

export const rollSkill = (value: number) => {
  let dice = Math.floor(value / 4);
  let mod = value - dice * 4;
  let rolls: number[] = [];
  let total = 0;
  for (let i = 0; i < dice; i++) {
    let roll = Math.floor(Math.random() * 6) + 1;
    rolls.push(roll);

    if (roll === 6) {
      dice += 2;
      continue;
    }

    total += roll;
  }

  return {
    rolls: rolls,
    total: total + mod,
  };
};
