const grid = document.querySelector('.grid');
const width = 100;
const height = 20;

class Block {
    constructor(xAxis, yAxis) {
        this.bottomLeft = [xAxis, yAxis];
        this.bottomRight = [xAxis + width, yAxis];
        this.topLeft = [xAxis, yAxis + height];
        this.topRight = [xAxis + width, yAxis + height];
    }
}

const blocks = [
    new Block(10, 270),
    new Block(120, 270),
    new Block(230, 270),
    new Block(340, 270),
    new Block(450, 270),
    new Block(10, 270),
    new Block(120, 270),
    new Block(230, 270),
    new Block(340, 270),
    new Block(450, 270),
    new Block(10, 270),
    new Block(120, 270),
    new Block(230, 270),
    new Block(340, 270),
    new Block(450, 270),

]

//add blocks to grid
function addBlocks() {
    for (i = 0; i < blocks.length; i++) {
        const block = document.createElement('div');
        block.classList.add('block');
        block.style.left = blocks[i].bottomLeft[0] + "px";
        block.style.bottom = blocks[i].bottomLeft[1] + "px";
        grid.appendChild(block);
    }
}

addBlocks();