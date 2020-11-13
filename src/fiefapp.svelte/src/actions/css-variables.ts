export function cssFontSize(node: HTMLElement, size: number) {
  setFontSize(node, size);

  return {
    update(size: number) {
      setFontSize(node, size);
    },
  };
}

function setFontSize(node: HTMLElement, size: number) {
  node.style.setProperty('--size', size.toString());
}
