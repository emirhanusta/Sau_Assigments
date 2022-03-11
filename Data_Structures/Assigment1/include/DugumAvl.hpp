#ifndef DUGUMAVL_HPP
#define DUGUMAVL_HPP
#include"DogruKuyrugu.hpp"
class DugumAvl
{
public:
    DogruKuyrugu* k;
    DugumAvl(DogruKuyrugu* kuyruk);
    int veri;

    DugumAvl* sol;
    DugumAvl* sag;
};

#endif