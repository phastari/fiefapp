export const parseT6String = (value: string): number => {
  if (typeof value === 'string') {
    let i = value.toUpperCase().indexOf('T');
    let t6 = parseInt(value.substring(0, i));
    let mod = 0;
    let modIndex = value.indexOf('+');
    if (modIndex !== -1) {
      mod = parseInt(value.substring(modIndex + 1, modIndex + 2));
    }

    if (!isNaN(t6) && mod === -1) {
      return t6 * 4;
    } else if (!isNaN(t6) && mod !== -1) {
      return t6 * 4 + mod;
    }
  }

  return 0;
};

export const parseT6Number = (value: number): string => {
  if (typeof value === 'number') {
    let t6 = Math.floor(value / 4);
    let mod = value >= 0 ? value - t6 * 4 : value - t6 * -4;

    if (mod === 0) {
      return `${t6}T6`;
    } else {
      return `${t6}T6+${mod}`;
    }
  }

  return `0`;
};
