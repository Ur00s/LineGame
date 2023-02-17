using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linije_73_2019
{
    public class Pretraga
    {

        /*
        bool CLinijeDlg::PostojiPutDo(int v, int k)
        {
            // trazi se put od (lbVrsta, lbKolona) do (v,k)
            queue<pair<int, int>> red;
            red.push(make_pair(lbVrsta, lbKolona));
            bool nadjen = false;
            pair<int, int> tmp, kraj(v, k);
            bool presao[9][9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    presao[i][j] = false;
            presao[lbVrsta][lbKolona] = true;
            while (!nadjen && !red.empty())
            {
                tmp = red.front();
                red.pop();
                if (tmp == kraj)
                    nadjen = true;
                else
                {
                    // polje levo
                    if (tmp.second - 1 >= 0 && m[tmp.first][tmp.second - 1] == 0 && !presao[tmp.first][tmp.second - 1])
                    {
                        red.push(make_pair(tmp.first, tmp.second - 1));
                        presao[tmp.first][tmp.second - 1] = true;
                    }
                    // polje desno
                    if (tmp.second + 1 < n && m[tmp.first][tmp.second + 1] == 0 && !presao[tmp.first][tmp.second + 1])
                    {
                        red.push(make_pair(tmp.first, tmp.second + 1));
                        presao[tmp.first][tmp.second + 1] = true;
                    }
                    // polje gore
                    if (tmp.first - 1 >= 0 && m[tmp.first - 1][tmp.second] == 0 && !presao[tmp.first - 1][tmp.second])
                    {
                        red.push(make_pair(tmp.first - 1, tmp.second));
                        presao[tmp.first - 1][tmp.second] = true;
                    }
                }
                // polje dole
                if (tmp.first + 1 < n && m[tmp.first + 1][tmp.second] == 0 && !presao[tmp.first + 1][tmp.second])
                {
                    red.push(make_pair(tmp.first + 1, tmp.second));
                    presao[tmp.first + 1][tmp.second] = true;
                }
            }
        }
        return nadjen;
        */
    }

}
